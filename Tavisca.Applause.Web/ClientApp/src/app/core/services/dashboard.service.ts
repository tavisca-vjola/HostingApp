import { Timeline } from "./../../shared/models/dashboard/dashboard-timeline";
import { TimeSheet } from "./../../shared/models/dashboard/TimeSheet";
import { Observable } from "rxjs";
import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { GithubStatistics } from "../../shared/models/dashboard/githubStatistics";
import { Employee } from "../../shared/models/dashboard/employee";
import { RecentBadgeWinner } from "../../shared/models/dashboard/recent-winner";

@Injectable({
  providedIn: "root"
})
export class DashboardService {
  githubStatsUrl: string = "api/GithubStatistics";
  timeSheetUrl: string = "api/TimeSheetStatistics";
  recentBadgeWinnerUrl: string = "api/badges/recentbadgewinners";
  dashboardTimelineUrl: string = "api/badges/badgetimeline";
  constructor(private http: HttpClient) {}

  getGithubStatistics(): Observable<GithubStatistics> {
    return this.http.get<GithubStatistics>(this.githubStatsUrl);
  }
  getTimeSheetStatistics(): Observable<TimeSheet[]> {
    return this.http.get<TimeSheet[]>(this.timeSheetUrl);
  }

  getRecentBadgeWinners(limit: number): Observable<RecentBadgeWinner> {
    let params = new HttpParams().set("limit", limit.toString());
    return this.http.get<RecentBadgeWinner>(this.recentBadgeWinnerUrl, {
      params: params
    });
  }

  getBadgesTimeline(pagestate: string, pagesize: number): Observable<Timeline> {
    let params = new HttpParams()
      .set("pageState", pagestate)
      .set("pagesize", pagesize.toString());
    return this.http.get<Timeline>(this.dashboardTimelineUrl, {
      params: params
    });
  }
}
