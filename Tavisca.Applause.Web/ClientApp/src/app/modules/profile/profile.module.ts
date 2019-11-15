import { NgbTabsetModule } from "@ng-bootstrap/ng-bootstrap";
import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ProfileComponent } from "./profile.component";
import { Routes, RouterModule } from "@angular/router";
import { UserDetailComponent } from "./components/user-detail/user-detail.component";
import { BreadcrumbComponent } from "./components/breadcrumb/breadcrumb.component";
import { AchievementItemComponent } from "./components/achievement-item/achievement-item.component";
import { UserProfileComponent } from "./components/user-profile/user-profile.component";
import { UserTimelineComponent } from "./components/user-timeline/user-timeline.component";
import { TimelineItemComponent } from "./components/timeline-item/timeline-item.component";
import { InfiniteScrollModule } from "ngx-infinite-scroll";
import { PipeModule } from "../../shared/pipe/pipe.module";

const routes: Routes = [
  {
    path: "",
    component: ProfileComponent
  }
];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NgbTabsetModule,
    InfiniteScrollModule,
    PipeModule.forRoot()
  ],
  declarations: [
    ProfileComponent,
    UserDetailComponent,
    BreadcrumbComponent,
    AchievementItemComponent,
    UserProfileComponent,
    UserTimelineComponent,
    TimelineItemComponent
  ]
})
export class ProfileModule {}
