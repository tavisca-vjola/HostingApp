import { Component, OnInit, Input } from "@angular/core";
import {
  RewardedEmployee,
  Employee
} from "../../../../shared/models/rewards/RewardedEmployee";
import { AppConstants } from "../../../../configs/constants/app-constants";
import { Router } from "@angular/router";

@Component({
  selector: "rewards-timeline",
  templateUrl: "./rewards-timeline.component.html",
  styleUrls: ["./rewards-timeline.component.css"]
})
export class RewardsTimelineComponent implements OnInit {
  @Input() rewardedEmployee: RewardedEmployee;

  constructor(private router: Router) {}

  onEmployeeNameSelect(employee: Employee) {
    if (employee != null)
      this.router.navigate(["userprofile"], { state: { data: employee } });
  }

  ngOnInit() {}
}
