export class Award {
  id: string;
  employeeId: string;
  type: string;
  description: string;
  year: number;
  month: number;
  name: string;
}

export class AwardResponse {
  awards: Award[];
  pageState: string;
}
