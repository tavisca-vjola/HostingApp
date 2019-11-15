import { Component, OnInit, EventEmitter, Output } from "@angular/core";
import { AppConstants } from "../../../../configs/constants/app-constants";

@Component({
  selector: "app-breadcrumb",
  templateUrl: "./breadcrumb.component.html",
  styleUrls: ["./breadcrumb.component.css"]
})
export class BreadcrumbComponent implements OnInit {
  labels = AppConstants.labels;
  @Output() display = new EventEmitter();
  constructor() {}
  showUsers() {
    this.display.emit();
  }

  ngOnInit() {}
}
