import { EmployeeService } from "./../../core/services/employee.service";
import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { debounceTime, distinctUntilChanged, map } from "rxjs/operators";
import { EmployeeCard } from "../../shared/models/employee-card";
import { Page } from "../../shared/models/page";
import { Router } from "@angular/router";
import { Employee } from "../../shared/models/dashboard/employee";

@Component({
  selector: "app-users",
  templateUrl: "./users.component.html",
  styleUrls: ["./users.component.css"]
})
export class UsersComponent implements OnInit {
  employeeCards: Employee[] = [];
  employeeSearchParam: any;
  currentPage: Page;
  paginationStates: Page[] = [];
  pageSize = 18;

  constructor(private empService: EmployeeService, private _route: Router) {}

  ngOnInit() {
    this.getEmployees(null, this.pageSize);
  }

  searchEmployee(employeeSearchParam: string) {
    this.empService
      .getSearchedEmployees(this.employeeSearchParam)
      .subscribe(
        data => (
          (this.employeeCards = data.employeeList),
          this.updatePageState(data.pageState)
        )
      );
  }

  getEmployees(pageState: string, pageSize: number): void {
    this.empService.getEmployeeCards(pageState, pageSize).subscribe(data => {
      this.employeeCards = data.employeeList;
      this.updatePageState(data.pageState);
    });
  }

  onSelect(employee: Employee): void {
    this._route.navigate(["userprofile"], { state: { data: employee } });
  }

  getPreviousPage() {
    if (this.currentPage.pageNumber > 0) {
      var requestedPageNumber = this.currentPage.pageNumber - 1;
      var requiredPageStateToSendForPage =
        requestedPageNumber == 0
          ? { state: null }
          : this.paginationStates.find(page => {
              return page.pageNumber === requestedPageNumber - 1;
            });

      this.empService
        .getEmployeeCards(requiredPageStateToSendForPage.state, this.pageSize)
        .subscribe(
          data => (
            (this.employeeCards = data.employeeList),
            this.updatePageState(data.pageState)
          )
        );
    }
  }

  getNextPage() {
    this.empService
      .getEmployeeCards(this.currentPage.state, this.pageSize)
      .subscribe(
        data => (
          (this.employeeCards = data.employeeList),
          this.updatePageState(data.pageState)
        )
      );
  }

  updatePageState(currentPageState: string) {
    if (currentPageState != null) {
      if (this.paginationStates.length == 0) {
        var firstPage = { pageNumber: 1, state: currentPageState };
        this.paginationStates.push(firstPage);
        this.currentPage = firstPage;
      } else {
        let pageState = this.paginationStates.find(
          page => page.state === currentPageState
        );

        if (pageState == null) {
          pageState = {
            pageNumber: this.paginationStates.length + 1,
            state: currentPageState
          };
          this.paginationStates.push(pageState);
        }

        this.currentPage = pageState;
      }
    }
  }
}
