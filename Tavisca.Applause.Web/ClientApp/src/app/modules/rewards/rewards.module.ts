import { RewardsTimelineComponent } from "./components/rewards-timeline/rewards-timeline.component";
import { FormsModule } from "@angular/forms";
import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RewardsComponent } from "./rewards.component";
import { Routes, RouterModule } from "@angular/router";
import {
  NgbTabsetModule,
  NgbPaginationModule,
  NgbDatepickerModule,
  NgbDropdownModule
} from "@ng-bootstrap/ng-bootstrap";

const routes: Routes = [
  {
    path: "",
    component: RewardsComponent
  }
];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    FormsModule,
    NgbTabsetModule,
    NgbPaginationModule,
    NgbDatepickerModule,
    NgbDropdownModule
  ],
  declarations: [RewardsComponent, RewardsTimelineComponent]
})
export class RewardsModule {}
