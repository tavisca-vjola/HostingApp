import { AppConstants } from "./../../../../configs/constants/app-constants";
import { Component, Input, OnInit } from "@angular/core";
import { BadgeRule, PlatformRule } from "../../../../shared/models/rules";

@Component({
  selector: "rule-tabs",
  templateUrl: "./rule-tabs.component.html"
})
export class NgbdtabsBasicComponent {
  @Input("badgeRules") badgeRules: BadgeRule;
  @Input("platformRules") platformRules: PlatformRule;

  applauseruletext = AppConstants.applauseruletext;

  currentJustify = "simple";
  currentOrientation = "horizontal";
}
