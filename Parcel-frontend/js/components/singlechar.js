export default function SingleChar(char, gameid,video,image){
    if(gameid == 1)
    return `
    <div>
        <img class='ow_single-char' src = ${image}>
        <p>${char.name}</p>
        <p>${char.health}</p>
        <p>${char.description})}</p>
        

    </div>
    `
    else if(gameid == 2)
    return `
    <div class='single-char-container'>
        <img class='lol_single-char' src = ${image}>
        <h3>${char.name}, ${char.title}</h3>
        <p>${char.lore}</p>
        <iframe width="560" height="315" src="https://www.youtube.com/embed/${video}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        
        ${char.spells.map(spell=>{
            return `
            <p>${spell.name}</p>
            <p>${spell.description}</p>
            `
    }).join("")}
      
    </div>
    `
}