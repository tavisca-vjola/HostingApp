import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { SummaryPipe } from "./summary/summary.pipe";
import { DateAgoPipe } from "./DateAgo/dateAgo.pipe";

@NgModule({
  imports: [CommonModule],
  declarations: [DateAgoPipe, SummaryPipe],
  exports: [DateAgoPipe, SummaryPipe]
})
export class PipeModule {
  static forRoot() {
    return {
      ngModule: PipeModule,
      providers: []
    };
  }
}
