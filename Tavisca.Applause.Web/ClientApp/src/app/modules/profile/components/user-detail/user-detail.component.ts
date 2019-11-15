import { Employee } from "./../../../../shared/models/employee";
import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";

@Component({
  selector: "user-detail",
  templateUrl: "./user-detail.component.html",
  styleUrls: ["./user-detail.component.css"]
})
export class UserDetailComponent implements OnInit {
  @Input() employee: Employee;

  constructor() {}

  ngOnInit() {}
}
