import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
//import {TaskDto } from './TaskDto';



@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public tasks: TaskDto[];
    title: string = "";
    deadline: Date = (null) as any;
    description: string = "";
    public status = Status;
    public priority = PriorityState;

    public newTask: { status: string; deadline: Date; description: string; priority: string; title: string } = {
        status: Status.ToDo,
        deadline: new Date(),
        description: "",
        priority: PriorityState.Low,
        title: ""
    };

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        this.refresh();
    }

    private refresh() {
        this.http.get(this.baseUrl + 'api/Task').subscribe(
            result => {
                this.tasks = result.json() as TaskDto[];
            },
            error => {
                console.error(error);
            });
    }

    public chooseStatus(id: number, status: string) {
        const patchBody = {
            newStatus: status
        };

        this.http.patch(this.baseUrl + 'api/task/' + id, patchBody).subscribe(
            result => {
                this.refresh();
            },
            error => {
                console.error(error);
            });
    }

    public choosePriority(id: number, priority: string) {
        const patchBody = {
            newPriority: priority
        };

        this.http.patch(this.baseUrl + 'api/task/' + id, patchBody).subscribe(
            result => {
                this.refresh();
            },
            error => {
                console.error(error);
            });
    }

    public deleteTask(id: number) {
        this.http.delete(this.baseUrl + 'api/task/' + id).subscribe(
            result => {
                this.refresh();
            },
            error => {
                console.error(error);
            }
        );
    }

    onSubmit(): void {
        this.addTask();
    }

    addTask(): void {
        //create task from submit
        this.newTask.title = this.title;
        this.newTask.deadline = this.deadline;
        this.newTask.description = this.description;

        //post task to server
        this.http.post(this.baseUrl + 'api/Task', this.newTask).subscribe(result => {
            this.title = "";
            this.deadline = new Date();
            this.description = "";
            this.refresh();
            console.log("Nowe zadanie zosta³o dodane");
        });
    }

}

interface TaskDto {
    status: Status;
    deadline: Date;
    title: string;
    description: string;
    priority: PriorityState;
}


enum PriorityState {
    Low = "Low",
    Normal="Normal",
    High="High"
}

enum Status {
    ToDo = "ToDo",
    InProgress = "InProgress",
    Done = "Done"
}
