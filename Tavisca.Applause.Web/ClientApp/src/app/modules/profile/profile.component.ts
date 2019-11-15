import { Component, OnInit } from "@angular/core";
import { EmployeeService } from "../../core/services/employee.service";
import { Router } from "@angular/router";
import { Employee } from "../../shared/models/dashboard/employee";

@Component({
  selector: "app-profile",
  templateUrl: "./profile.component.html",
  styleUrls: ["./profile.component.css"]
})
export class ProfileComponent implements OnInit {
  empId: string;
  employee: Employee;
  constructor(private empService: EmployeeService, private router: Router) {}
  ngOnInit() {
    if (history.state.data == null) this.router.navigate(["users"]);
    else {
      this.empId = history.state.data.id;
      this.getEmployee();
    }
  }

  getEmployee() {
    this.empService.getEmployee(this.empId).subscribe(employee => {
      this.employee = employee;
    });
  }
}
