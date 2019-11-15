import { Component, OnInit, HostListener } from "@angular/core";
import { Router } from "@angular/router";

import { PerfectScrollbarConfigInterface } from "ngx-perfect-scrollbar";

@Component({
  selector: "app-AppLayout",
  templateUrl: "./AppLayout.component.html",
  styleUrls: ["./AppLayout.component.css"]
})
export class AppLayoutComponent implements OnInit {
  color = "bluedark";
  showSettings = false;
  showMinisidebar = false;
  showDarktheme = false;
  showHorizontalNav = true;
  showBoxedtheme = true;
  showRtl = false;

  public innerWidth: any;

  public config: PerfectScrollbarConfigInterface = {};

  constructor(public router: Router) {}

  ngOnInit() {
    this.handleLayout();
  }

  @HostListener("window:resize", ["$event"])
  onResize(event) {
    this.handleLayout();
  }

  toggleSidebar() {
    this.showMinisidebar = !this.showMinisidebar;
  }

  handleLayout() {
    this.innerWidth = window.innerWidth;
    if (this.innerWidth < 1170) {
      this.showMinisidebar = true;
    } else {
      this.showMinisidebar = false;
    }
  }
}
