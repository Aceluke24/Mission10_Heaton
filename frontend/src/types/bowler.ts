export type Team = {
    teamId: number;
    teamName: string;
}

export type Bowler = {
    bowlerId: number;
    bowlerFirstName: string;
    bowlerMiddleInit: string;
    bowlerLastName: string;
    bowlerAddress: string;
    bowlerCity: string;
    bowlerState: string;
    bowlerZip: string;
    bowlerPhoneNumber: string;
    team: Team;
}