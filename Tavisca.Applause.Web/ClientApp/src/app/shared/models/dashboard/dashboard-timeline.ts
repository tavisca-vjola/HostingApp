import { Employee } from "./employee";

export class Badge {
  name: string;
  type: string;
  iconUrl: string;
}

export class EmployeeBadge {
  employeeId: string;
  dateTime: Date;
  badge: Badge;
}

export class EmployeeBadgeMapping {
  employee: Employee;
  employeeBadge: EmployeeBadge;
}

export class Timeline {
  employeeBadgeMappings: EmployeeBadgeMapping[];
  pageState: string;
}
