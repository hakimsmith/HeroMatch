export default function SingleChar(char, gameid,video,image){
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
        <p>${char.name}, ${char.title}</p>
        <p>${char.lore}</p>
        <iframe width="560" height="315" src="https://www.youtube.com/embed/${video}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        <img src = ${image}>
        
    ${char.spells.map(spell=>{
        return `
        <p>${spell.name}</p>
        <p>${spell.description}</p>
        `
    }).join("")}
      
    </div>
    `
}