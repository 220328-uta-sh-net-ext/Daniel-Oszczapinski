class Animal{
    readonly name: string;
    private species: string;

    constructor(name:string,species:string){
        this.name = name;
        this.species = species;
    }

    get getspecies(): string {
        return this.species
    }
    set setspiecies(sp: string){
        this.species = sp;
    }

    move(feet:number): void {
        console.log(`The animal ${this.name} moved ${feet}`);
    }
}

let an = new Animal('Petty', 'Cat')
an.move(5);