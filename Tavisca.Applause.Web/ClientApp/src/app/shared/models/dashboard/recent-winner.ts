import { RewardStats } from "../reward-stats";

export class Gold {
  id: string;
  firstName: string;
  lastName: string;
  tribe: string;
  squad: string;
  profilePictureUrl: string;
  iEnabled: boolean;
  email: string;
  rewardStats: RewardStats;
}

export class Silver {
  id: string;
  firstName: string;
  lastName: string;
  tribe: string;
  squad: string;
  profilePictureUrl: string;
  iEnabled: boolean;
  email: string;
  rewardStats: RewardStats;
}

export class Bronze {
  id: string;
  firstName: string;
  lastName: string;
  tribe: string;
  squad: string;
  profilePictureUrl: string;
  iEnabled: boolean;
  email: string;
  rewardStats: RewardStats;
}

export class RecentBadgeWinner {
  gold: Gold[];
  silver: Silver[];
  bronze: Bronze[];
}
