import { Routes } from "@angular/router";

import { AppLayoutComponent } from "./shared/layout/AppLayout/AppLayout.component";
import { TimesheetComponent } from "./modules/timesheet/timesheet.component";

export const Approutes: Routes = [
  { path: "", redirectTo: "/dashboard", pathMatch: "full" },
  {
    path: "",
    component: AppLayoutComponent,
    children: [
      {
        path: "dashboard",
        loadChildren: () =>
          import(`./modules/dashboard/dashboard.module`).then(
            m => m.DashboardModule
          )
      },
      {
        path: "users",
        loadChildren: () =>
          import(`./modules/users/users.module`).then(m => m.UsersModule)
      },
      {
        path: "rewards",
        loadChildren: () =>
          import(`./modules/rewards/rewards.module`).then(m => m.RewardsModule)
      },
      {
        path: "rules",
        loadChildren: () =>
          import(`./modules/applauseRule/applauseRule.module`).then(
            m => m.ApplauseRuleModule
          )
      },
      {
        path: "userprofile",
        loadChildren: () =>
          import(`./modules/profile/profile.module`).then(m => m.ProfileModule)
      }
    ]
  },
  {
    path: "timesheet",
    component: TimesheetComponent
  },
  {
    path: "**",
    redirectTo: "/dashboard"
  }
];
