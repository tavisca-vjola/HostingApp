import { Component, OnInit } from "@angular/core";
import { RuleService } from "../../core/services/rule.service";
import { BadgeRule, PlatformRule } from "../../shared/models/rules";
@Component({
  selector: "app-applauseRule",
  templateUrl: "./applauseRule.component.html",
  styleUrls: ["./applauseRule.component.css"]
})
export class ApplauseRuleComponent implements OnInit {
  badgeRules: BadgeRule[];
  platformRules: PlatformRule[];
  constructor(private ruleService: RuleService) {}

  ngOnInit() {
    this.getRule();
  }

  getRule(): void {
    this.ruleService.getBadgeRules().subscribe(badgeRules => {
      this.badgeRules = badgeRules;
    });

    this.ruleService.getPlatformRules().subscribe(platformRules => {
      this.platformRules = platformRules;
    });
  }
}
