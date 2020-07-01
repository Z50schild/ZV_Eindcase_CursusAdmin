import { CursusInstantie } from "./CursusInstantie";

export class Cursus {
    id: number;
    duur: number;
    titel: string;
    code: string;
    cursusinstanties: CursusInstantie[];
}