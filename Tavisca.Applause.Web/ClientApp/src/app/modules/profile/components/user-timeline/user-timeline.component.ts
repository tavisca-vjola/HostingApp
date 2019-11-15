import { Activity } from "./../../../../shared/models/user-profile/user-timeline";
import { Component, OnInit, Input } from "@angular/core";
import { AppConstants } from "../../../../configs/constants/app-constants";
import { Employee } from "../../../../shared/models/dashboard/employee";
import { EmployeeService } from "../../../../core/services/employee.service";
import { tap } from "rxjs/operators";
import { Award } from "../../../../shared/models/user-profile/employee-award";

@Component({
  selector: "user-timeline",
  templateUrl: "./user-timeline.component.html",
  styleUrls: ["./user-timeline.component.css"]
})
export class UserTimelineComponent implements OnInit {
  labels = AppConstants.labels;
  finishedForTimeline: boolean = false;
  finishedForAward: boolean = false;
  activities: Activity[];
  awards: Award[];
  throttle = 1000;
  scrollDistance = 1;
  empId: string;
  pageStateForTimeline: string = null;
  pageSizeForTimeline: number = 5;
  pageStateForAward: string = null;
  pageSizeForAwards: number = 5;
  @Input() employee: Employee;

  constructor(private empService: EmployeeService) {}

  getUserTimeline() {
    this.empService
      .getEmployeeTimeline(
        this.empId,
        this.pageStateForTimeline,
        this.pageSizeForTimeline
      )
      .pipe(
        tap(response => {
          this.activities = response.activities;
          this.pageStateForTimeline = response.pageState;
          if (this.pageStateForTimeline == "null" || !this.activities)
            this.finishedForTimeline = true;
        })
      )
      .subscribe();
  }
  onScrollDownForTimeline() {
    if (this.activities.length > 15) {
      this.finishedForTimeline = true;
    } else {
      this.finishedForTimeline = false;
      this.empService
        .getEmployeeTimeline(
          this.empId,
          this.pageStateForTimeline,
          this.pageSizeForTimeline
        )
        .subscribe(response => {
          if (response.activities.length > 0)
            this.activities.push(...response.activities);
        });
    }
  }
  ngOnInit() {
    this.empId = this.employee.id;
    this.getUserTimeline();
    this.getEmployeeAwards();
  }

  getEmployeeAwards() {
    this.empService
      .getEmployeeAwards(
        this.empId,
        this.pageStateForAward,
        this.pageSizeForAwards
      )
      .pipe(
        tap(response => {
          this.awards = response.awards;
          this.pageStateForAward = response.pageState;
          if (this.pageStateForAward == "null" || !this.activities)
            this.finishedForAward = true;
        })
      )
      .subscribe();
  }
  onScrollDownForAward() {
    if (this.awards.length > 15) {
      this.finishedForAward = true;
    } else {
      this.finishedForAward = false;
      this.empService
        .getEmployeeAwards(
          this.empId,
          this.pageStateForAward,
          this.pageSizeForAwards
        )
        .subscribe(response => {
          if (response.awards.length > 0) this.awards.push(...response.awards);
        });
    }
  }
}
