import { Component, OnInit, Input } from "@angular/core";
import { AppConstants } from "../../../../configs/constants/app-constants";
import { EmployeeCard } from "../../../../shared/models/employee-card";
import { Employee } from "../../../../shared/models/dashboard/employee";

@Component({
  selector: "user-profile",
  templateUrl: "./user-profile.component.html",
  styleUrls: ["./user-profile.component.css"]
})
export class UserProfileComponent implements OnInit {
  labels = AppConstants.labels;
  imagesUrl = AppConstants.imagesUrl;

  @Input() employee: Employee;
  constructor() {}

  ngOnInit() {}
}
