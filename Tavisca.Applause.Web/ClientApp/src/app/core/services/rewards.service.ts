import { RewardType } from "./../../shared/models/enums";
import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { RewardedEmployee } from "../../shared/models/rewards/RewardedEmployee";

@Injectable({
  providedIn: "root"
})
export class RewardsService {
  private kudosWinnersUrl =  `api/awards/kudos`;
  private shoutoutWinnersUrl = `api/awards/shououts`;
  private annualWinnerUrl = `api/awards`

  constructor(private http: HttpClient) {}

  getKudosWinners(month: string, year: string): Observable<RewardedEmployee[]> {
    return this.http.get<RewardedEmployee[]>(`${this.kudosWinnersUrl}?month=${month}&year=${year}`);
  }

  getShoutoutWinners(month: string, year: string): Observable<RewardedEmployee[]> {
    return this.http.get<RewardedEmployee[]>(`${this.shoutoutWinnersUrl}?month=${month}&year=${year}`);
  }

  getAnnualWinners(year: string): Observable<RewardedEmployee[]> {
    return this.http.get<RewardedEmployee[]>(`${this.annualWinnerUrl}?year=${year}`);
  }
  
}
