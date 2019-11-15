import { AwardResponse } from "./../../shared/models/user-profile/employee-award";
import { EmployeeCardPaginationResult } from "../../shared/models/employee-pagination-result";
import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";
import { Employee } from "../../shared/models/dashboard/employee";
import { UserTimeLineResponse } from "../../shared/models/user-profile/user-timeline";

@Injectable({
  providedIn: "root"
})
export class EmployeeService {
  private employeesUrl = "api/employees";
  private activityUrl = "api/activity/";
  private awardUrl = "api/awards/employee/";
  constructor(private http: HttpClient) {}

  getEmployee(empId: string): Observable<Employee> {
    return this.http.get<Employee>(this.employeesUrl + `/${empId}`);
  }

  getEmployeeCards(
    pageState: string,
    pageSize: number
  ): Observable<EmployeeCardPaginationResult> {
    var params = new HttpParams()
      .set("pageSize", pageSize.toString())
      .set("pageState", pageState);

    return this.http.get<EmployeeCardPaginationResult>(this.employeesUrl, {
      params: params
    });
  }

  getSearchedEmployees(
    searchParam: string
  ): Observable<EmployeeCardPaginationResult> {
    var searchUrl = this.employeesUrl + "/search/" + searchParam;
    return this.http.get<EmployeeCardPaginationResult>(searchUrl);
  }

  getEmployeeTimeline(empId: string, pageState: string, pageSize: number) {
    var params = new HttpParams()
      .set("pageSize", pageSize.toString())
      .set("pageState", pageState);
    return this.http.get<UserTimeLineResponse>(this.activityUrl + `${empId}`, {
      params
    });
  }

  getEmployeeAwards(empId: string, pageState: string, pageSize: number) {
    var params = new HttpParams()
      .set("pageSize", pageSize.toString())
      .set("pageState", pageState);
    return this.http.get<AwardResponse>(this.awardUrl + `${empId}`, {
      params
    });
  }
}
