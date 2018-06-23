let statuses = [
    {status:4,name:'John'},
    {status:2,name:'Gary'},
    {status:1,name:'Lisa'},
    {status:3,name:'Sarah'},
    {status:2,name:'Bob'},
    {status:1,name:'LaJuana'}
];

for(let statuses of statuses){
    writeString(getPersonStatusDescription(personStatus));
}

function getPersonStatusDescription(personStatus){

    let status = 'Status for' + personStatus.name + 'is';    

    let counter = 0;
    for (let counter = 0; counter < statuses.length; counter++){
        let status = "";
        if (statuses [counter] === 1){
                status = "Alive";        
        } else if (statuses [counter] === 2) {
                status = "Zombie";
        } else if (statuses [counter] === 3) {
                status = "Dead";
        } else {
                status = "Unknown";
        }
        return status;
    }
}

function writeString(value){
    console.log(value);
}