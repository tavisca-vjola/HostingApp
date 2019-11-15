import { AppConstants } from "./../../../configs/constants/app-constants";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-footer",
  templateUrl: "./footer.component.html",
  styleUrls: ["./footer.component.css"]
})
export class FooterComponent implements OnInit {
  footertext = AppConstants.footerTexts;
  constructor() {}

  ngOnInit() {}
  getCurrentYear() {
    return new Date().getFullYear();
  }
}
