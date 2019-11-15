import { RecentBadgeWinner } from "./../../../../shared/models/dashboard/recent-winner";
import { Component, OnInit, Input } from "@angular/core";

@Component({
  selector: "honour-banner",
  templateUrl: "./honour-banner.component.html",
  styleUrls: ["./honour-banner.component.css"]
})
export class HonourBannerComponent implements OnInit {
  @Input() recentBadgeWinners: RecentBadgeWinner;
  @Input() badgeType: string;
  constructor() {}

  ngOnInit() {}
}
