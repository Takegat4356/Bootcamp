
//Typescripting elements updated from Zombie Sample
//statuses: number[]
//names:string[]
//counter:number
//status: string
//statusNumber: number
//value:string
//:void

let statuses: number[] = [4, 3, 1, 2, 4, 1]
let names:string[] = ['John','Gary','Lisa','Sarah','Bob', 'LaJuana']

for (let counter:number = 0; counter < statuses.length; counter++){
    let status: string = getStatus (statuses[counter]);
    writeStatus(names [counter] + " has a status of " + status);    
}

//we want to pass our dependencies (statusNumber) into our method
function getStatus(statusNumber: number){
    let status = "";
    if (statusNumber === 1){
            status = "Alive";        
    } else if (statusNumber === 2) {
            status = "Zombie";
    } else if (statusNumber === 3) {
            status = "Dead";
    } else {
            status = "Unknown";
    }
return status;
}

function writeStatus(value:string):void{
    console.log(value);
}