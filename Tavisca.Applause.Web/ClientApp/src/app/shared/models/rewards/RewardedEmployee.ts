export class RewardStats {
  employeeId: string;
  points: number;
  bronzeBadge: number;
  silverBadge: number;
  goldBadge: number;
  annual: number;
  kudos: number;
  shoutOut: number;
}

export class Employee {
  id: string;
  firstName: string;
  lastName: string;
  tribe: string;
  squad: string;
  profilePictureUrl: string;
  iEnabled: boolean;
  email?: any;
  rewardStats: RewardStats;
}

export class Awards {
  id?: any;
  employeeId: string;
  type: string;
  description: string;
  year: number;
  month: number;
  name: string;
}

export class RewardedEmployee {
  employee: Employee;
  awards: Awards;
}
