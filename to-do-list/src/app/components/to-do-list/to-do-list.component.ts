import { Component } from '@angular/core';
import { Todo } from '../../models/todo';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-to-do-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './to-do-list.component.html',
  styleUrl: './to-do-list.component.css'
})
export class ToDoListComponent {
  list: Todo[] = [
    { task: "Do homework", completed: false, duration: 1.25 },
    { task: "Wash dishes", completed: true, duration: 0.5 },
    { task: "Finish ToDoList lab", completed: false, duration: 2.0 },
    { task: "Walk dog", completed: true, duration: 0.5 }
  ]

  removeToDo(item: Todo) : void {
    const index = this.list.indexOf(item, 0);
    if (index > -1) {
      this.list.splice(index, 1);
    }
  }
}
