import { AppConstants } from "./../../../configs/constants/app-constants";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-header",
  templateUrl: "./header.component.html",
  styleUrls: ["./header.component.css"]
})
export class HeaderComponent implements OnInit {
  navTabs = AppConstants.navTabs;
  app = AppConstants.app;

  constructor() {}

  ngOnInit() {}
}
