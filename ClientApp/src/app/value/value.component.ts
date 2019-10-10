import { ValueService } from './../value.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  constructor(private valueService: ValueService) { }

  ngOnInit() {
    this.valueService.getValues()
      .subscribe(values => console.log(values));
  }

}
