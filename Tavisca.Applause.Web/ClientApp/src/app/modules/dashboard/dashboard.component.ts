import {
  Gold,
  Silver,
  Bronze
} from "./../../shared/models/dashboard/recent-winner";
import { DashboardService } from "./../../core/services/dashboard.service";
import { Awards } from "./../../core/mocks/mock-employee-awards";
import { EmployeeAward } from "./../../shared/models/employee-award";
import { Component, OnInit } from "@angular/core";
import { NgbCarouselConfig } from "@ng-bootstrap/ng-bootstrap";

@Component({
  selector: "app-dashboard",
  templateUrl: "./dashboard.component.html",
  styleUrls: ["./dashboard.component.css"],
  providers: [NgbCarouselConfig]
})
export class DashboardComponent implements OnInit {
  recentGoldBadgeWinners: Gold[];
  recentSilverBadgeWinners: Silver[];
  recentBronzeBadgeWinners: Bronze[];
  constructor(
    config: NgbCarouselConfig,
    private dashboardSerivce: DashboardService
  ) {
    config.interval = 2000;
    config.wrap = true;

    config.showNavigationArrows = true;
    config.showNavigationIndicators = true;
  }

  ngOnInit() {
    this.getRecentBadgeWinners(6);
  }

  getRecentBadgeWinners(limit: number) {
    this.dashboardSerivce
      .getRecentBadgeWinners(limit)
      .subscribe(recentBagdeWinners => {
        this.recentGoldBadgeWinners = recentBagdeWinners.gold;
        this.recentSilverBadgeWinners = recentBagdeWinners.silver;
        this.recentBronzeBadgeWinners = recentBagdeWinners.bronze;
      });
  }
}
