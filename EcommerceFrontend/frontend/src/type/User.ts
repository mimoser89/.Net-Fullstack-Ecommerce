export interface User {
    id: string
    firstName: string
    lastName: string
    email: string
    password: string
    role: "admin" | "customer"
    avatar: string
}

export interface UserState {
    users: User[],
    currentUser?: User | null,
    loading: boolean,
    error: string | null
    isLoggedIn: boolean 
}

export interface UserCredentials {
    email: string
    password: string
}

export interface UserUpdate {
    id: number
    update: Omit<User, "id">
}

export interface NewUser {
    firstName: string
    lastName: string
    email: string
    password: string
}