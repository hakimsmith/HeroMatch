export default function SingleChar(char, gameid){
    if(gameid == 1)
    return `
    <div>
        <p>${char.name}</p>
        <p>${char.health}</p>
        <p>${char.description})}</p>
    </div>
    `
    else if(gameid == 2)
    return `
    <div>
        <p>${char.title}</p>
        <p>${char.name}</p>
        <p>${char.lore}</p>
    </div>
    `
}