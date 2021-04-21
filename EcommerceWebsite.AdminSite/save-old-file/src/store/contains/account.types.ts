//Declare actions todo
export const LOGIN_REQUEST = "LOGIN_REQUEST";
export const LOGIN_SUCCESS = "LOGIN_SUCCESS";
export const LOGIN_FAILURE = "LOGIN_FAILURE";

//Declare state account
export interface AccountState{
    access_token: string | null;
    refresh_token: string | null;
    expires_in: number | 0;
    error: string | null
}

//Declare type of return actions
interface LoginRequest{
    type: typeof LOGIN_REQUEST, 
    payload:{
        username: string;
        password: string;
    }
}

interface LoginSuccess{
    type: typeof LOGIN_SUCCESS,
    payload:{
        access_token: string;
        refresh_token: string;
        expires_in: number;
    }
}

interface LoginFailure{
    type: typeof LOGIN_FAILURE,
    payload:{
        error: string
    }
}

export type AccountActionTypes =  
|LoginRequest
|LoginSuccess
|LoginFailure