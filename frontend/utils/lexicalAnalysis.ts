/**
 * utils/lexicalAnalysis.ts
 * Simulador de análisis léxico en el frontend.
 * 👉 Puedes ELIMINAR este archivo cuando conectes el backend.
 */
import type { LexicalReport } from '@/types/lexical'

export function analyzeText(input: string): LexicalReport {
  const text = (input || '')
    .toLowerCase()
    .replace(/[\n\r\t]/g, ' ')
    .replace(/[^a-záéíóúñü0-9\s]/gi, '')

  const words = text.split(/\s+/).filter(Boolean)
  const total = words.length

  const freq = new Map<string, number>()
  for (const w of words) {
    freq.set(w, (freq.get(w) || 0) + 1)
  }

  let top: [string, number] | null = null
  let least: [string, number] | null = null
  for (const [k, v] of freq.entries()) {
    if (!top || v > top[1]) top = [k, v]
    if (!least || v < least[1]) least = [k, v]
  }

  const sorted = Array.from(freq.entries()).sort((a, b) => b[1] - a[1])
  const breakdown = sorted.map(([w, c]) => `${w}: ${c}`).join('\n')

  return {
    totalWords: total,
    topWord: top,
    leastWord: least,
    breakdown
  }
}
