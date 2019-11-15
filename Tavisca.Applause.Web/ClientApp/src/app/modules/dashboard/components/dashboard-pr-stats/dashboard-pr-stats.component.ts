import { AppConstants } from "./../../../../configs/constants/app-constants";
import { Component, OnInit } from "@angular/core";
import { GithubStatistics } from "../../../../shared/models/dashboard/githubStatistics";
import { DashboardService } from "../../../../core/services/dashboard.service";

@Component({
  selector: "pull-request-stats",
  templateUrl: "./dashboard-pr-stats.component.html",
  styleUrls: ["./dashboard-pr-stats.component.css"]
})
export class PullRequestStatsComponent implements OnInit {
  githubstats: GithubStatistics;
  numberOfPullRequestReviewed: number;
  reviewPercent: number;
  dashboardtext = AppConstants.dashboardtext;
  constructor(private dashboard: DashboardService) {}

  ngOnInit() {
    this.getGithubStatistics();
  }
  getGithubStatistics() {
    this.dashboard.getGithubStatistics().subscribe(stats => {
      this.githubstats = stats;
      this.numberOfPullRequestReviewed = this.githubstats.numberOfPRsWithComments;
      this.reviewPercent = Math.floor(
        this.getGithubStatisticsPercent(this.githubstats)
      );
    });
  }

  getGithubStatisticsPercent(data: GithubStatistics) {
    let pullRequestWithComment = data.numberOfPRsWithComments;
    let pullRequestWithoutComment = data.numberOfPRsWithOutComments;
    return (
      (pullRequestWithComment * 100) /
      (pullRequestWithComment + pullRequestWithoutComment)
    );
  }
}
