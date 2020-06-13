
export class User {
    userId: number;
    userFirstName: string;
    userLastName: string;
    userEmail: string;
    userPassword: string;
    userGooglePassword: string;

    constructor(userId: number, userFirstName: string, userLastName: string, userEmail: string, userPassword: string, userGooglePassword: string) {
        this.userId = userId;
        this.userFirstName = userFirstName;
        this.userLastName = userLastName;
        this.userEmail = userEmail;
        this.userPassword = userPassword;
        this.userGooglePassword = userGooglePassword;
    }
}