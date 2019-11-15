export class EmployeeActivity {
  id: string;
  name: string;
  platform: string;
  displayName: string;
  actionVerb: string;
  iconUrl: string;
}

export class Activity {
  employeeId: string;
  activityType: string;
  dateTime: Date;
  activity: EmployeeActivity;
}

export class UserTimeLineResponse {
  activities: Activity[];
  pageState?: any;
}
