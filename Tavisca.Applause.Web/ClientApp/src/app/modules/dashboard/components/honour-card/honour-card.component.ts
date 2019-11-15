import { RecentBadgeWinner } from "./../../../../shared/models/dashboard/recent-winner";
import { Employee } from "../../../../shared/models/employee";
import { Component, OnInit, Input } from "@angular/core";

@Component({
  selector: "honour-card",
  templateUrl: "./honour-card.component.html",
  styleUrls: ["./honour-card.component.css"]
})
export class HonourCardComponent implements OnInit {
  @Input() recentBadgeWinner: RecentBadgeWinner;
  @Input() badgeType: string;
  constructor() {}
  ngOnInit() {}
}
