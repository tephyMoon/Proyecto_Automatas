export interface LexicalReport {
  totalWords: number
  topWord: [string, number] | null
  leastWord: [string, number] | null
  breakdown: string
}
