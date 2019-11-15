import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ApplauseRuleComponent } from "./applauseRule.component";
import { Routes, RouterModule } from "@angular/router";
import { NgbTabsetModule } from "@ng-bootstrap/ng-bootstrap";
import { NgbdtabsBasicComponent } from "./components/rule-tabs/rule-tabs.component";

const routes: Routes = [
  {
    path: "",
    component: ApplauseRuleComponent
  }
];

@NgModule({
  imports: [CommonModule, NgbTabsetModule, RouterModule.forChild(routes)],
  declarations: [ApplauseRuleComponent, NgbdtabsBasicComponent]
})
export class ApplauseRuleModule {}
