import { Component } from "@angular/core";
import { Contacts, Contact } from "@ionic-native/contacts";

@Component({ templateUrl: './nameMatcher.html', selector: 'page-namematcher' })
export class NameMatcherPage {
    firstPersonName: string;
    secondPersonName: string;
    result: number;
    constructor(private _contacts: Contacts) {
        this.firstPersonName = "";
        this.secondPersonName = "";
        this.result = 0;

    }
    matchName() {
        console.log("called...");
        if (this.firstPersonName == "" || this.secondPersonName == "") {
            return this.result = 0;
        }

        let str = this.firstPersonName.concat(this.secondPersonName);
        console.log(str);
        let ascisum = 0;
        for (let i = 0; i < str.length; i++) {
            ascisum += str.charCodeAt(i);
        }
        this.result = ascisum % 101;
        console.log(this.result);


    }

    pickContactName(value) {

        console.log(value);

        this._contacts.pickContact()
            .then((response: Contact) => {

                if (value == "fname") {
                    this.firstPersonName = response.displayName;
                    this.matchName();
                    return;
                }
                this.secondPersonName = response.displayName;
                this.matchName();

            }
            );

    }

}