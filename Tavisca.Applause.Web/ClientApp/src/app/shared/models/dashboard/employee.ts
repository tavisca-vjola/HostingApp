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
