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
    { task: "Do homework", completed: false, duration: 1.25, priority: "HIGH" },
    { task: "Wash dishes", completed: true, duration: 0.5, priority: "LOW" },
    { task: "Finish ToDoList lab", completed: false, duration: 2.0, priority: "NORMAL" },
    { task: "Walk dog", completed: true, duration: 0.5, priority: "LOW" }
  ]

  filteredList: Todo[] = this.list;

  removeToDo(item: Todo) : void {
    const index = this.list.indexOf(item, 0);
    if (index > -1) {
      this.list.splice(index, 1);
    }
  }

  getPriority(item: Todo) : string {
    if (item.priority === 'HIGH') {
      return '↑ High priority'
    }
    else if (item.priority === 'LOW') {
      return '↓ Low priority'
    }
    return ''
  }

  filterList(param: string) : void {
    this.filteredList = [];

    for (let i of this.list) {
      if (i.task.startsWith(param)) {
        this.filteredList.push(i);
      }
    }
  }

  filterByPriority(priority: string) : void {
    this.filteredList = [];

    for (let i of this.list) {
      if (i.priority === priority) {
        this.filteredList.push(i);
      }
    }
  }
}
