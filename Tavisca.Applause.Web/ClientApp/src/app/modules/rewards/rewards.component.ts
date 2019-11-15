import { RewardsService } from "./../../core/services/rewards.service";
import { Component, OnInit } from "@angular/core";
import { RewardedEmployee } from "../../shared/models/rewards/RewardedEmployee";
import { AppConstants } from "../../configs/constants/app-constants";

@Component({
  selector: "app-rewards",
  templateUrl: "./rewards.component.html",
  styleUrls: ["./rewards.component.css"]
})
export class RewardsComponent implements OnInit {
  kudosWinners: RewardedEmployee[] = [];
  shoutoutsWinners: RewardedEmployee[] = [];
  annualWinners: RewardedEmployee[] = [];
  selectedKudosMonth: string;
  selectedKudosYear: string;
  selectedShoutoutMonth: string;
  selectedShoutoutYear: string;
  selectedAnnualYear: string;
  dropDownYears: string[] = [];
  dropDownMonths: string[] = [];

  constructor(private rewardsService: RewardsService) {
    const currentYear: number = new Date().getFullYear();
    const currentMonth: number = new Date().getMonth() + 1;

    this.selectedAnnualYear = this.selectedAnnualYear
      ? this.selectedAnnualYear
      : currentYear.toString();

    this.selectedKudosMonth = this.selectedKudosMonth
      ? this.selectedKudosMonth
      : currentMonth.toString();
    this.selectedKudosYear = this.selectedKudosYear
      ? this.selectedKudosYear
      : currentYear.toString();

    this.selectedShoutoutMonth = this.selectedShoutoutMonth
      ? this.selectedShoutoutMonth
      : currentMonth.toString();
    this.selectedShoutoutYear = this.selectedShoutoutYear
      ? this.selectedShoutoutYear
      : currentYear.toString();
  }

  public rewardTitles: any = AppConstants.rewardTitles;
  public noContent: any = AppConstants.messages.rewardsPage.noContent;

  ngOnInit() {
    const currentYear = new Date().getFullYear();
    for (let year = 2014; year <= currentYear; year++)
      this.dropDownYears.push(year.toString());
    for (let month = 1; month <= 12; month++)
      this.dropDownMonths.push(month.toString());

    this.getKudosWinners({
      month: this.selectedKudosMonth,
      year: this.selectedKudosYear
    });
    this.getShoutoutWinners({
      month: this.selectedShoutoutMonth,
      year: this.selectedShoutoutYear
    });
    this.getAnnualWinners(this.selectedAnnualYear);
  }

  getKudosWinners(kudosMonthAndYear: { month: any; year: any }) {
    this.selectedKudosMonth = kudosMonthAndYear.month;
    this.selectedKudosYear = kudosMonthAndYear.year;
    this.rewardsService
      .getKudosWinners(kudosMonthAndYear.month, kudosMonthAndYear.year)
      .subscribe(kudosWinners => (this.kudosWinners = kudosWinners));
  }

  getShoutoutWinners(shoutoutMonthAndYear: { month: any; year: any }) {
    this.selectedShoutoutMonth = shoutoutMonthAndYear.month;
    this.selectedShoutoutYear = shoutoutMonthAndYear.year;
    this.rewardsService
      .getShoutoutWinners(shoutoutMonthAndYear.month, shoutoutMonthAndYear.year)
      .subscribe(shoutoutWinners => (this.shoutoutsWinners = shoutoutWinners));
  }

  getAnnualWinners(year: string) {
    this.selectedAnnualYear = year;
    this.rewardsService
      .getAnnualWinners(year)
      .subscribe(annualWinners => (this.annualWinners = annualWinners));
  }
}
