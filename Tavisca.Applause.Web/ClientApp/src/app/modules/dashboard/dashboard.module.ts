import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { DashboardComponent } from "./dashboard.component";
import { Routes, RouterModule } from "@angular/router";

import { NgxChartsModule } from "@swimlane/ngx-charts";
import { DashboardTimelineComponent } from "./components/dashboard-timeline/dashboard-timeline.component";
import { PullRequestStatsComponent } from "./components/dashboard-pr-stats/dashboard-pr-stats.component";
import { DashboardTimesheetStatsComponent } from "./components/dashboard-timesheet-stats/dashboard-timesheet-stats.component";
import { HonourCardComponent } from "./components/honour-card/honour-card.component";
import { HonourBannerComponent } from "./components/honour-banner/honour-banner.component";
import { InfiniteScrollModule } from "ngx-infinite-scroll";
import {
  NgbProgressbarModule,
  NgbCarouselModule,
  NgbTabsetModule
} from "@ng-bootstrap/ng-bootstrap";
import { PipeModule } from "../../shared/pipe/pipe.module";

const routes: Routes = [
  {
    path: "",
    component: DashboardComponent
  }
];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NgbProgressbarModule,
    NgxChartsModule,
    NgbCarouselModule,
    NgbTabsetModule,
    InfiniteScrollModule,
    PipeModule.forRoot()
  ],
  declarations: [
    DashboardComponent,
    DashboardTimelineComponent,
    PullRequestStatsComponent,
    DashboardTimesheetStatsComponent,
    HonourCardComponent,
    HonourBannerComponent
  ]
})
export class DashboardModule {}
