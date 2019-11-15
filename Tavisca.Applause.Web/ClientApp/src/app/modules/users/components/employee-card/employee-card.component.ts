import { Router } from "@angular/router";
import { EmployeeCard } from "./../../../../shared/models/employee-card";
import { Component, OnInit, Input } from "@angular/core";
import { AppConstants } from "../../../../configs/constants/app-constants";

@Component({
  selector: "employee-card",
  templateUrl: "./employee-card.component.html",
  styleUrls: ["./employee-card.component.css"]
})
export class EmployeeCardComponent implements OnInit {
  @Input() employee: EmployeeCard;
  medalIcons = AppConstants.imagesUrl.medals;
  dummyUserImage = AppConstants.dummyUser.Image;
  constructor(private router: Router) {}

  ngOnInit() {}
  onSelect(employee: EmployeeCard) {
    this.router.navigate(["userprofile"], { state: { data: employee } });
  }
}
