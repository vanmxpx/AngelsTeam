import {Directive, Input, EventEmitter, ElementRef, Renderer, Inject, OnInit} from '@angular/core';

@Directive({
  // tslint:disable-next-line:directive-selector
  selector: '[focus]'
})
export class FocusDirective implements OnInit {
  // tslint:disable-next-line:no-input-rename
  @Input('focus') focusEvent: EventEmitter<boolean>;

  constructor(@Inject(ElementRef) private element: ElementRef, private renderer: Renderer) {
  }

  ngOnInit() {
    this.focusEvent.subscribe(event => {
      this.renderer.invokeElementMethod(this.element.nativeElement, 'focus', []);
    });
  }
}
