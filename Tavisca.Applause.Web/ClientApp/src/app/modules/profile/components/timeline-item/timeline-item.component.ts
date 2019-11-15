import { Component, OnInit, Input } from "@angular/core";
import { AppConstants } from "../../../../configs/constants/app-constants";
import { Employee } from "../../../../shared/models/dashboard/employee";

@Component({
  selector: "timeline-item",
  templateUrl: "./timeline-item.component.html",
  styleUrls: ["./timeline-item.component.css"]
})
export class TimelineItemComponent implements OnInit {
  labels = AppConstants.labels;
  @Input() activity;
  @Input() employee: Employee;
  constructor() {}

  ngOnInit() {}
}
