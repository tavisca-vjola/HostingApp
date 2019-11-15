export class BadgeRule {
  id: string;
  badgeType: string;
  description: string;
  points: number;
}

export class PlatformRule {
  id: string;
  timesheet: Platform[];
  github: Platform[];
}
export class Platform {
  platformName: string;
  ruleName: string;
  description: string;
  points: number;
}
