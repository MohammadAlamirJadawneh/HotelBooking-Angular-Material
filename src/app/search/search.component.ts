import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  @Output() searchValueEvent = new EventEmitter<string>();
  SearchByAddress: string = '';
  constructor(private matSnackBar: MatSnackBar) {
  }
  goToCards() {
    if (!this.SearchByAddress) {
      this.matSnackBar.open(`can't empty`, `dismiss`, {
        duration: 3000, verticalPosition: 'top',
      });
    }
    this.searchValueEvent.emit(this.SearchByAddress);
  }
  ClearSearchByAddress() {
    this.SearchByAddress = ''
  }
}