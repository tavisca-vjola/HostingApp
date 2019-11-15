import { AppConstants } from "./../../../../configs/constants/app-constants";
import { EmployeeBadgeMapping } from "../../../../shared/models/dashboard/dashboard-timeline";
import { Component, OnInit } from "@angular/core";
import { DashboardService } from "../../../../core/services/dashboard.service";
import { tap } from "rxjs/operators";

@Component({
  selector: "dashboard-timeline",
  templateUrl: "./dashboard-timeline.component.html",
  styleUrls: ["./dashboard-timeline.component.css"]
})
export class DashboardTimelineComponent implements OnInit {
  activites: EmployeeBadgeMapping[];
  pageState: string = "null";
  pageSize: number = 5;
  finished: boolean = false;
  throttle = 1000;
  scrollDistance = 1;
  dashboardtext = AppConstants.dashboardtext;
  constructor(private dashboardService: DashboardService) {}

  ngOnInit() {
    this.getBadgesTimeline();
  }

  getBadgesTimeline() {
    this.dashboardService
      .getBadgesTimeline(this.pageState, this.pageSize)
      .pipe(
        tap(activites => {
          this.activites = activites.employeeBadgeMappings;
          this.pageState = activites.pageState;
          if (this.pageState == "null" || !this.activites) this.finished = true;
        })
      )
      .subscribe();
  }
  onScrollDown() {
    if (this.activites.length > 15) {
      this.finished = true;
    } else {
      this.finished = false;
      this.dashboardService
        .getBadgesTimeline(this.pageState, this.pageSize)
        .subscribe(activities => {
          this.activites.push(...activities.employeeBadgeMappings);
          this.pageState = activities.pageState;
          if (this.pageState == "null") this.finished = true;
        });
    }
  }
}
