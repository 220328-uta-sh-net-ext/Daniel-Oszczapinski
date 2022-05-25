"use strict";
class Animal {
    constructor(name, species) {
        this.name = name;
        this.species = species;
    }
    get getspecies() {
        return this.species;
    }
    set setspiecies(sp) {
        this.species = sp;
    }
    move(feet) {
        console.log(`The animal ${this.name} moved ${feet}`);
    }
}
let an = new Animal('Petty', 'Cat');
an.move(5);
