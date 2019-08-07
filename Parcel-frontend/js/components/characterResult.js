export default function CharacterResult(characters){
    return `
   <div class = "char-results">

    ${characters.map(character =>{

            return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.image}>            
        <h3 class='name'>${character.name}</h3>
        </a>

        </div>
    
    
    `        

    }).join("")}
   </div>
   <button value='1' class="allChar">View All Characters</button>
    `
}