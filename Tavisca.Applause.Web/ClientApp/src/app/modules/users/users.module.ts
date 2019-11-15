import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { UsersComponent } from "./users.component";
import { RouterModule, Routes } from "@angular/router";
import { InfiniteScrollModule } from "ngx-infinite-scroll";
import { NgbTabsetModule } from "@ng-bootstrap/ng-bootstrap";
import { FormsModule } from "@angular/forms";
import { EmployeeCardComponent } from "./components/employee-card/employee-card.component";

const routes: Routes = [
  {
    path: "",
    component: UsersComponent
  }
];
@NgModule({
  imports: [
    CommonModule,
    InfiniteScrollModule,
    RouterModule.forChild(routes),
    NgbTabsetModule,
    FormsModule
  ],
  declarations: [UsersComponent, EmployeeCardComponent]
})
export class UsersModule {}
