import { AppConstants } from "./../../../../configs/constants/app-constants";
import { DashboardService } from "../../../../core/services/dashboard.service";
import { Component, OnInit } from "@angular/core";
import { organizationdata } from "./chartData";

@Component({
  selector: "dashboard-timesheet-stats",
  templateUrl: "./dashboard-timesheet-stats.component.html",
  styleUrls: ["./dashboard-timesheet-stats.component.css"]
})
export class DashboardTimesheetStatsComponent implements OnInit {
  tribeTimesheetstats: any[];
  organizationtimeSheetStats: any[];
  chartDimension = [400, 290];
  showLabels = true;
  showXAxis = true;
  showYAxis = true;
  organizationStats = organizationdata;
  dashboardtext = AppConstants.dashboardtext;

  colorScheme = {
    domain: [
      "#745af2",
      "#ffb22b",
      "#ef5350",
      "#06d79c",
      "#398bf7",
      "#cccccc",
      "#FF5722"
    ]
  };
  timeSheetColorScheme = {
    domain: ["#8BC34A", "#FFEB3B", "#F44336"]
  };

  constructor(private dashbaordService: DashboardService) {
    this.organizationtimeSheetStats = organizationdata;
  }

  ngOnInit() {
    for (let i = 0; i < 25; i++) {
      this.organizationStats.push({ name: "", value: 0 });
    }
    this.getTimeSheetStatictics();
  }
  getTimeSheetStatictics() {
    this.dashbaordService.getTimeSheetStatistics().subscribe(data => {
      this.tribeTimesheetstats = data.map(stats => ({
        name: stats.tribeName,
        value: stats.numberOfEmployeesFillingTimeSheet
      }));
    });
  }
}
