import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'people',
    templateUrl: './people.component.html'
})
export class PeopleComponent {
    public people: Person[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/People/GetList').subscribe(result => {
            this.people = result.json() as Person[];
        }, error => console.error(error));
    }
}

interface Person {
    firstName: string;
    lastName: string;
    email: string;
    country: string;
    countryDescription: string;
}