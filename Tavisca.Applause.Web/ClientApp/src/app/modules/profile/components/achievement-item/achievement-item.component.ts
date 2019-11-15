import { Awards } from "./../../../../core/mocks/mock-employee-awards";
import { Component, OnInit, Input } from "@angular/core";
import { AchievementMocks } from "../../../../core/mocks/achievement-mock";
import { Employee } from "../../../../shared/models/dashboard/employee";
import { Award } from "../../../../shared/models/user-profile/employee-award";

@Component({
  selector: "achievement-item",
  templateUrl: "./achievement-item.component.html",
  styleUrls: ["./achievement-item.component.css"]
})
export class AchievementItemComponent implements OnInit {
  recentcomments = AchievementMocks;
  @Input() employee: Employee;
  @Input() award: Award;
  constructor() {}

  ngOnInit() {}
}
