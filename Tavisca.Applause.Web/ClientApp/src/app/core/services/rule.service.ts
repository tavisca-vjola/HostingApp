import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { BadgeRule, PlatformRule } from "../../shared/models/rules";

@Injectable({
  providedIn: "root"
})
export class RuleService {
  private badgesRulesUrl = "api/rules/badges";
  private platformRulesUrl = "api/rules/platform";

  constructor(private http: HttpClient) {}
  getBadgeRules(): Observable<BadgeRule[]> {
    return this.http.get<BadgeRule[]>(this.badgesRulesUrl);
  }
  getPlatformRules(): Observable<PlatformRule[]> {
    return this.http.get<PlatformRule[]>(this.platformRulesUrl);
  }
}
